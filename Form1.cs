using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
# w folderze projektu Visual Studio
git init
git add .
git commit -m "init: initial project files (Visual Studio generated)"
# utworzenie gałęzi main i ustawienie remote (zamień URL)
git branch -M main
git remote add origin https://github.com/JKuchnio/KalkulatorProcentowy1.git
git push -u origin main
namespace KalkulatorProcentowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
