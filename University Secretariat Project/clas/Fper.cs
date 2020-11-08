using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace personnelMangement.clas
{
    public class Fper
    {
        public static bool AlowFolPer(string StrPath)
        { return AlowFolPer(StrPath, true); }
        public static bool AlowFolPer(string StrPath, bool SubFooldersAndFiles)
        { return AlowFolPer(StrPath, SubFooldersAndFiles, "Everyone"); }
        public static bool AlowFolPer(string StrPath, string strUser)
        { return AlowFolPer(StrPath, true, strUser); }
        public static bool AlowFolPer(string StrPath, bool SubFooldersAndFiles, string strUser)
        {
            if (!System.IO.Directory.Exists(StrPath))
                return false;
            try
            {
                DirectorySecurity dSecurity = Directory.GetAccessControl(StrPath);


                FileSystemAccessRule fsar;
                //fsar = new FileSystemAccessRule(strUser, FileSystemRights.FullControl, AccessControlType.Allow);
                fsar = new FileSystemAccessRule(strUser, FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow);
                dSecurity.AddAccessRule(fsar);
                try
                {
                    Directory.SetAccessControl(StrPath, dSecurity);
                }
                catch (Exception) { return false; }
                if (SubFooldersAndFiles)
                {
                    bool blnOk = true;
                    foreach (string x in Directory.GetDirectories(StrPath))
                        blnOk = blnOk && AlowFolPer(x, true, strUser);
                    foreach (string x in Directory.GetFiles(StrPath))
                        blnOk = blnOk && AlowFilePer(x, strUser);
                    return blnOk;
                }
                else
                    return true;
            }
            catch (Exception) { return false; }
        }
        public static bool AlowFilePer(string StrPath)
        { return AlowFilePer(StrPath, "Everyone"); }
        public static bool AlowFilePer(string StrPath, string strUser)
        {
            FileSecurity fSecurity = File.GetAccessControl(StrPath);
            FileSystemAccessRule fsar = new FileSystemAccessRule(
                strUser
                , FileSystemRights.FullControl
                //, InheritanceFlags.None , PropagationFlags.NoPropagateInherit
                , AccessControlType.Allow);
            fSecurity.AddAccessRule(fsar);
            try
            {
                File.SetAccessControl(StrPath, fSecurity);
                return true;
            }
            catch (Exception)
            { return false; }
        }
    }
}
