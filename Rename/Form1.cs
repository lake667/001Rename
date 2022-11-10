using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename
{
    public partial class Form_RenameProgram : Form
    {
        public static string _timenow = DateTime.Now.ToString("yyyyMMdd");
        string addTimeOfFront = _timenow;
                     
        public Form_RenameProgram()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        public static List<string > fileNames=new List<string>();
        public string shortestName;
        private void ListBox_fileview_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < s.Length; i++)
            {
                listBox_fileview.Items.Add(s[i]);
                listBox_fileview.SetSelected(i, true);
                fileNames.Add(Path.GetFileNameWithoutExtension(s[i]));
            }
            //20221107增加查找最短的文件名
            
            FindShortestName(fileNames, out shortestName);
            textBox1.Text = shortestName;
        }
        //20221107增加查找最短的文件名
        public void FindShortestName(List<string> fileNames, out string shortestName)
        {
            try
            {
                shortestName = fileNames[0];
                foreach (string item in fileNames)
                {
                    if (item.Length <= shortestName.Length)
                        shortestName = item;
                }


            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void ListBox_fileview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }



        //退出窗口
        private void Button_Canceal_Click(object sender, EventArgs e)
        {
            this.Close();                //关闭当前窗口，无法退出程序，如果有托管线程（非主线程），也无法完全退出。

            Application.Exit();          //强制中止所有消息，退出所有的窗体，如果有托管线程（非主线程），也无法彻底退出。

            Application.ExitThread();    //强制中止调用线程中的所有消息，同样面临其它线程无法正确退出的问题。

            Environment.Exit(0);         //最彻底的退出方法。
        }


        //确定重命名文件
        private void Button_OK_Click(object sender, EventArgs e)
        {
            int count = listBox_fileview.SelectedItems.Count;//判断选中了几个
            List<string> itemValues = new List<string>();
            try
            {

                if (count == 0)
                {
                    //如果所选项个数为0，则进行提示
                    MessageBox.Show("请选择文件！");
                }
                else
                {
                    //将选中项的内容添加到字符串列表中
                    for (int i = 0; i < count; i++)
                    {
                        itemValues.Add(listBox_fileview.SelectedItems[i].ToString());

                    }
                    //按照内容从列表框中移除数据
                    for (int i = 0; i < count; i++)
                    {                                               
                        string directory = Path.GetDirectoryName(itemValues[i]);
                        string oldName = Path.GetFileNameWithoutExtension(itemValues[i]);
                        string ext = Path.GetExtension(itemValues[i]);

                        StringBuilder newName = new StringBuilder(oldName);
                        newName.Replace(textBox1.Text.ToString(), textBox2.Text.ToString());                  
                       
                        //改名后的完整路径；
                        string newDirectoryandFileName = directory + @"\" + addTimeOfFront + newName.ToString() + ext;
                        File.Move(itemValues[i], newDirectoryandFileName);
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show("请检查生成文件是否错误");
            }
        }
        //浏览文件并将选择的文件加入列表框
        



        //删除文件框中选定的项目
        private void Button_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                int count = listBox_fileview.SelectedItems.Count;//判断选中了几个
                List<string> itemToDelete = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    itemToDelete.Add(listBox_fileview.SelectedItems[i].ToString());
                }
                for (int i = 0; i < count; i++)
                {
                    listBox_fileview.Items.Remove(itemToDelete[i]);
                }
            }
            catch
            {
                MessageBox.Show("请检查文件是否错误");
            }
        }
        

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog_1.InitialDirectory =@"C:\Users\Administrator\Desktop\";
            this.openFileDialog_1.Filter = "Dwg files(*.dwg)|*.dwg|All files (*.*)|*.*";
            // Allow the user to select multiple files.
            this.openFileDialog_1.Multiselect = true;
            this.openFileDialog_1.Title = "请选择需要进行处理的文件";
        }

        //对话框添加选中文件至列表框listbox
        private void FindDictionary_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = this.openFileDialog_1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {              
                for (int i = 0; i < openFileDialog_1.FileNames.Length; i++)
                {
                    listBox_fileview.Items.Add(openFileDialog_1.FileNames[i]);   
                }

                for (int i = 0; i < listBox_fileview.Items.Count; i++)
                {
                    listBox_fileview.SetSelected(i, true);
                }
            }
            //{
            //// Read the files
            //foreach (String file in openFileDialog_1.FileNames)
            //  {

            //     int count = listBox_fileview.SelectedItems.Count;//判断选中了几个
            //        List<string> itemValues = new List<string>();

            //        try
            //        {
            //            if (count == 0)
            //            {
            //                //如果所选项个数为0，则进行提示
            //                MessageBox.Show("请选择文件！");
            //            }
            //            else
            //            {
            //                //将选中项的内容添加到字符串列表中
            //                for (int i = 0; i < count; i++)
            //                {
            //                    itemValues.Add(listBox_fileview.SelectedItems[i].ToString());
            //                }
            //            }
            //        }

            //        catch (Exception ex)
            //        {
            //            // Could not load the image - probably related to Windows file system permissions.
            //            MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
            //                + ". You may not have permission to read the file, or " +
            //                "it may be corrupt.\n\nReported error: " + ex.Message);
            //        }
            //    }   
            //}

        }
        
        //文件全选或全不选 选项框
        private void CheckBox_Select(object sender, EventArgs e)
        {
            int count = listBox_fileview.Items.Count;
            if (checkBox_Select.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    listBox_fileview.SetSelected(i, true);
                }

            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    listBox_fileview.SetSelected(i, false);
                }
            }
        }
        //日期选项框
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                addTimeOfFront = null;
            }
        }
    }
}
