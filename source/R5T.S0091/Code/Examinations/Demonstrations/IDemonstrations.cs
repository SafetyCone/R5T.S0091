using System;

using R5T.T0141;


namespace R5T.S0091
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_UserProfileDirectoryPath()
        {
            var directoryPath = Instances.WindowsSpecialDirectoryPaths.UserProfile;

            Console.WriteLine(directoryPath);
        }
    }
}
