using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaveEditor
{
    public partial class Editor : Form
    {
        public List<byte> fileBytes;
        saveData saveFile = new saveData();


        public Editor()
        {
            InitializeComponent();
            unlockedCharactersTab.Enabled = false;
            generalGrid.Rows.Add("Studs", 0);
        }

        public class saveData
        {
            public List<byte> header;
            public List<byte> unk1;
            public List<byte> levelData1;
            public List<byte> unk2;
            public List<byte> levelData2;
            public List<byte> unk3;
            public List<byte> studsCollected;
            public List<byte> filePercent;
            public List<byte> goldBricks;
            public List<byte> goldBrickDoorUnlock;
            public List<byte> unk4;
            public List<byte> fileTime;
            public List<byte> customChar1Data;
            public List<byte> customChar2Data;
            public List<byte> levelData3;
            public List<byte> charUnlockData;
            public List<byte> checksum;
            public List<byte> footer;
            public List<byte> saveGameSection;

            public void SetContents(List<byte> bytes)
            {
                int offset = 0;

                header = bytes.GetRange(offset, 8232); offset += header.Count;
                unk1 = bytes.GetRange(offset, 30764); offset += unk1.Count;
                levelData1 = bytes.GetRange(offset, 792); offset += levelData1.Count;
                unk2 = bytes.GetRange(offset, 72); offset += unk2.Count;
                levelData2 = bytes.GetRange(offset, 76); offset += levelData2.Count;
                unk3 = bytes.GetRange(offset, 60); offset += unk3.Count;
                studsCollected = bytes.GetRange(offset, 4); offset += studsCollected.Count;
                filePercent = bytes.GetRange(offset, 2); offset += filePercent.Count;
                goldBricks = bytes.GetRange(offset, 2); offset += goldBricks.Count;
                goldBrickDoorUnlock = bytes.GetRange(offset, 2); offset += goldBrickDoorUnlock.Count;
                unk4 = bytes.GetRange(offset, 2); offset += unk4.Count;
                fileTime = bytes.GetRange(offset, 4); offset += fileTime.Count;
                customChar1Data = bytes.GetRange(offset, 56); offset += customChar1Data.Count;
                customChar2Data = bytes.GetRange(offset, 56); offset += customChar2Data.Count;
                levelData3 = bytes.GetRange(offset, 100); offset += levelData3.Count;
                charUnlockData = bytes.GetRange(offset, 340); offset += charUnlockData.Count;
                checksum = bytes.GetRange(offset, 4); offset += checksum.Count;
                footer = bytes.GetRange(offset, 4);


            }

            public IEnumerable<byte> GetContents()
            {
                return header
                .Concat(unk1)
                .Concat(levelData1)
                .Concat(unk2)
                .Concat(levelData2)
                .Concat(unk3)
                .Concat(studsCollected)
                .Concat(filePercent)
                .Concat(goldBricks)
                .Concat(goldBrickDoorUnlock)
                .Concat(unk4)
                .Concat(fileTime)
                .Concat(customChar1Data)
                .Concat(customChar2Data)
                .Concat(levelData3)
                .Concat(charUnlockData)
                .Concat(checksum)
                .Concat(footer);
            }

            public void GetChecksum(int bytes, System.Windows.Forms.TextBox box)
            {
                IEnumerable<byte> checksumSection = unk1
                .Concat(levelData1)
                .Concat(unk2)
                .Concat(levelData2)
                .Concat(unk3)
                .Concat(studsCollected)
                .Concat(filePercent)
                .Concat(goldBricks)
                .Concat(goldBrickDoorUnlock)
                .Concat(unk4)
                .Concat(fileTime)
                .Concat(customChar1Data)
                .Concat(customChar2Data)
                .Concat(levelData3)
                .Concat(charUnlockData);

                for (int i = 0; i <= checksumSection.Count() - 4; i += 4)
                {
                    bytes += BitConverter.ToInt32(checksumSection.Skip(0 + i).Take(4).ToArray());
                }
                checksum = BitConverter.GetBytes(bytes).ToList();
                box.Text = BitConverter.ToString(checksum.ToArray());
            }
        }

        private void openSaveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Save File";
            open.Filter = "All Files|*.*";
            open.FilterIndex = 0;
            open.RestoreDirectory = true;
            if (open.ShowDialog() != DialogResult.OK) { return; }
            string openPath = open.FileName;
            fileBytes = new List<byte>(File.ReadAllBytes(openPath));
            if (fileBytes.Count != 40572)
            {
                MessageBox.Show("That is not a valid save file", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            File.WriteAllBytes(openPath + ".bak", fileBytes.ToArray());
            saveFile.SetContents(fileBytes);

            savePathBox.Text = openPath;
            checksumBox.Text = BitConverter.ToString(saveFile.checksum.ToArray());
            saveButton.Enabled = true;
            checksumButton.Enabled = true;
            unlockedCharactersTab.Enabled = true;
            maxStudsButton.Enabled = true;
            setValuesButton.Enabled = true;
            generalGrid.Enabled = true;
            generalGrid[1, 0].Value = BitConverter.ToUInt32(saveFile.studsCollected.ToArray());


            characterGrid.Rows.Clear();

            for (int i = 0; i < saveFile.charUnlockData.Count; i++)
            {
                characterGrid.Rows.Add($"Slot {i + 1}", (saveFile.charUnlockData[i] == 0x3));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save?";
            save.Filter = "All Files|*.*";
            save.FilterIndex = 0;
            save.RestoreDirectory = true;
            if (save.ShowDialog() != DialogResult.OK) { return; }
            string savePath = save.FileName;
            File.WriteAllBytes(savePath, saveFile.GetContents().ToArray());
        }

        private void checksumButton_Click(object sender, EventArgs e)
        {
            saveFile.GetChecksum(6031769, checksumBox);
        }

        private void unlockCharacters_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < characterGrid.Rows.Count; i++)
            {
                characterGrid[1, i].Value = true;
            }
        }

        private void setCharacters_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < characterGrid.Rows.Count; i++)
            {
                if (characterGrid[1,i].Value.ToString() == "True") { saveFile.charUnlockData[i] = 0x3; }
                else { saveFile.charUnlockData[i] = 0x0; }
            }
            saveFile.GetChecksum(6031769, checksumBox);
        }

        private void openCharsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog chars = new OpenFileDialog();
            chars.Title = "Select Chars.txt File";
            chars.Filter = "Text File|*.txt*|All Files|*.*";
            chars.FilterIndex = 0;
            chars.RestoreDirectory = true;
            if (chars.ShowDialog() != DialogResult.OK) { return; }
            string charsPath = chars.FileName;
            charsPathBox.Text = charsPath;
            int offset = 0;
            foreach (string line in File.ReadAllLines(charsPath))
            {
                if (line.Contains("//") || line.Contains(";")) { }
                else if (line.Contains("\tfile "))
                {
                    characterGrid[0, offset].Value = line.Replace("\tfile ", "").Replace("\"","") ;
                    offset++;
                }
            }
        }

        private void maxStudsButton_Click(object sender, EventArgs e)
        {
            generalGrid[1, 0].Value = 0xEE6B2800;
        }

        private void setValuesButton_Click(object sender, EventArgs e)
        {
            saveFile.studsCollected = BitConverter.GetBytes(Convert.ToUInt32(generalGrid[1, 0].Value)).ToList();
            saveFile.GetChecksum(6031769, checksumBox);
        }
    }
}