@{
    AllNodes = @(
        @{
            NodeName="*"
            UserName="vagrant"
            Password="vagrant"
            Tempfolder="c:\temp"
            WWWRoot = "c:\inetpub\wwwroot"
            
            SqlServer = @{
                InstallConfig = "c:\vagrant\files\sqlserver.ini"
                ISOFile = "c:\vagrant\files\en_sql_server_2014_developer_edition_with_service_pack_1_x64_dvd_6668542.iso"
                SAPassword = "Vagrant123"    
            }
            
            Sitecore = @{
                Installer = "c:\vagrant\files\Sitecore 8.1 rev. 160302.exe"
                License = "c:\vagrant\files\license.xml"
                Name = "demo"
            }
            
            Mongo = @{
                DataFolder = "c:\mongo\data"
                ConfigFile = "c:\vagrant\files\mongod.cfg"
                MSIFile = "c:\vagrant\files\mongodb-win32-x86_64-2008plus-ssl-3.2.6-signed.msi"
                InstallerAppName = "MongoDB 3.2.6 2008R2Plus SSL (64 bit)"
                ServiceExe = "MongoDB\Server\3.2\bin\mongod.exe" 
            }
            
            Role=@("SqlServer", "WebServer", "MongoDB", "Sitecore")
         }
        @{
            NodeName="localhost"
         }
    )
}
