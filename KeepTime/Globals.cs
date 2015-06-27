using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace KeepTime {
    public static class Globals {
        public static readonly string GithubLink =
            "http://github.com/abluescarab/";
        public static readonly string ChangelogPath =
            Path.Combine(Application.StartupPath, "Resources", "changelog.txt");
        public static readonly string HelpFilePath = 
            Path.Combine(Application.StartupPath, "Resources", "help.html");

        public static Icon Icon_16x16 {
            get {
                return Icon.FromHandle(((Bitmap)Properties.Resources.icon_16x16).GetHicon());
            }
        }

        public static Icon Icon_32x32 {
            get {
                return Icon.FromHandle(((Bitmap)Properties.Resources.icon_32x32).GetHicon());
            }
        }

        public static Icon Icon_64x64 {
            get {
                return Icon.FromHandle(((Bitmap)Properties.Resources.icon_64x64).GetHicon());
            }
        }

        public static Icon Icon_128x128 {
            get {
                return Icon.FromHandle(((Bitmap)Properties.Resources.icon_128x128).GetHicon());
            }
        }

        public static Icon Icon_256x256 {
            get {
                return Icon.FromHandle(((Bitmap)Properties.Resources.icon_256x256).GetHicon());
            }
        }
    }
}
