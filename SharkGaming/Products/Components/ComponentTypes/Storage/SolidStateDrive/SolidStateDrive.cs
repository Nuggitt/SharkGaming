namespace SharkGaming.Products.Components.ComponentTypes.Storage.SolidStateDrive
{
    public class SolidStateDrive : StorageClass
    {
        public double DriveTransferRate { get; set; }
        public double FourKBRandomRead { get; set; }
        public double FourKBRandomWrite { get; set; }
        public double NANDFlashMemoryType { get; set; }

        public SolidStateDrive()
        {

        }

        public SolidStateDrive(double driveTransferRate, double fourKBRandomRead, double fourKBRandomWrite, double nandFlashMemoryType)
            : base()
        {
            DriveTransferRate = driveTransferRate;
            FourKBRandomRead = fourKBRandomRead;
            FourKBRandomWrite = fourKBRandomWrite;
            NANDFlashMemoryType = nandFlashMemoryType;
        }
    }
}
