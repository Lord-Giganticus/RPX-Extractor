using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace RPX.Extractor.Classes
{
    public class FTPiiU
    {
        public FtpClient Client;

        string TitleID { get; set; }

        public FTPiiU(string IP, TitleIdType idType)
        {
            Client = new FtpClient(IP);
            switch (idType)
            {
                case TitleIdType.Base:
                    TitleID = TitleIdStarters.Base;
                    break;
                case TitleIdType.Update:
                    TitleID = TitleIdStarters.Update;
                    break;
                case TitleIdType.DLC:
                    TitleID = TitleIdStarters.DLC;
                    break;
            }
        }

        public async ValueTask<ObservableCollection<(MemoryStream stream, string name)>> FindRPX(string titleid)
        {
            await Client.ConnectAsync();
            foreach (var d in await Client.GetListingAsync())
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains("storage_mlc"))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            foreach (var d in await Client.GetListingAsync(await Client.GetWorkingDirectoryAsync()))
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains("user"))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            foreach (var d in await Client.GetListingAsync(await Client.GetWorkingDirectoryAsync()))
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains("title"))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            foreach (var d in await Client.GetListingAsync(await Client.GetWorkingDirectoryAsync()))
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains(TitleID))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            foreach (var d in await Client.GetListingAsync(await Client.GetWorkingDirectoryAsync()))
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains(titleid))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            foreach (var d in await Client.GetListingAsync(await Client.GetWorkingDirectoryAsync()))
                if (d.Type is FtpFileSystemObjectType.Directory)
                    if (d.Name.Contains("code"))
                        await Client.SetWorkingDirectoryAsync(d.FullName);
            var l = new ObservableCollection<(MemoryStream stream, string name)>();
            foreach (var f in Client.GetListing(await Client.GetWorkingDirectoryAsync()))
                if (f.Type is FtpFileSystemObjectType.Directory)
                    if (f.Name.Contains(".rpx"))
                    {
                        var m = new MemoryStream();
                        if (await Client.DownloadAsync(m, f.FullName))
                            l.Add((m, f.Name));
                    }
                    else continue;
            return l;
        }
    }
}
