using Speq.Source.Models;
using Speq.Source.ViewModels.Core;
using System;
using System.Management;

namespace Speq.Source.ViewModels {
    public class CPUTabViewModel : ViewModel {

        #region Properties

        public CPU Cpu { get; set; }

        #endregion

        #region Constructor

        public CPUTabViewModel () {
            // Test getting all CPU related information here...
            ManagementObjectSearcher mos = new ManagementObjectSearcher( "SELECT * FROM Win32_Processor" );
            foreach ( ManagementObject mo in mos.Get() ) {
                Console.WriteLine( "===============================================================" );
                Console.WriteLine( "AddressWidth              :" + mo["AddressWidth"] );
                Console.WriteLine( "Architecture              :" + mo["Architecture"] );
                Console.WriteLine( "Availability              :" + mo["Availability"] );
                Console.WriteLine( "Caption                   :" + mo["Caption"] );
                Console.WriteLine( "ConfigManagerErrorCode    :" + mo["ConfigManagerErrorCode"] );
                Console.WriteLine( "ConfigManagerUserConfig   :" + mo["ConfigManagerUserConfig"] );
                Console.WriteLine( "CpuStatus                 :" + mo["CpuStatus"] );
                Console.WriteLine( "CreationClassName         :" + mo["CreationClassName"] );
                Console.WriteLine( "CurrentClockSpeed         :" + mo["CurrentClockSpeed"] );
                Console.WriteLine( "CurrentVoltage            :" + mo["CurrentVoltage"] );
                Console.WriteLine( "DataWidth                 :" + mo["DataWidth"] );
                Console.WriteLine( "Description               :" + mo["Description"] );
                Console.WriteLine( "DeviceID                  :" + mo["DeviceID"] );
                Console.WriteLine( "ErrorCleared              :" + mo["ErrorCleared"] );
                Console.WriteLine( "InstallDate               :" + mo["InstallDate"] );
                Console.WriteLine( "LoadPercentage            :" + mo["LoadPercentage"] );
                Console.WriteLine( "Name                      :" + mo["Name"] );
                Console.WriteLine( "NumberOfCores             :" + mo["NumberOfCores"] );
                Console.WriteLine( "NumberOfLogicalProcessors :" + mo["NumberOfLogicalProcessors"] );
                Console.WriteLine( "ProcessorID               :" + mo["ProcessorID"] );
                Console.WriteLine( "ProcessorType             :" + mo["ProcessorType"] );
                Console.WriteLine( "OtherFamilyDescription    :" + mo["OtherFamilyDescription"] );
                Console.WriteLine( "PNPDeviceID               :" + mo["PNPDeviceID"] );
                Console.WriteLine( "PowerManagementSupported  :" + mo["PowerManagementSupported"] );
                Console.WriteLine( "Revision                  :" + mo["Revision"] );
                Console.WriteLine( "Role                      :" + mo["Role"] );
                Console.WriteLine( "SocketDesignation         :" + mo["SocketDesignation"] );
                Console.WriteLine( "Status                    :" + mo["Status"] );
                Console.WriteLine( "StatusInfo                :" + mo["StatusInfo"] );
                Console.WriteLine( "Stepping                  :" + mo["Stepping"] );
                Console.WriteLine( "SystemCreationClassName   :" + mo["SystemCreationClassName"] );
                Console.WriteLine( "SystemName                :" + mo["SystemName"] );
                Console.WriteLine( "UniqueId                  :" + mo["UniqueId"] );
                Console.WriteLine( "UpgradeMethod             :" + mo["UpgradeMethod"] );
                Console.WriteLine( "Version                   :" + mo["Version"] );
                Console.WriteLine( "VoltageCaps               :" + mo["VoltageCaps"] );
            }
        }

        #endregion

    }
}
