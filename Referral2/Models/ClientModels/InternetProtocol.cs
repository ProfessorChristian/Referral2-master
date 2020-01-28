using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Referral2.Models.ClientModels
{
    public class InternetProtocol
    {
        public string PORT { get; set; }

        internal IPAddress ClientAddress
        {
            get
            {
                string _hostname = string.Empty;
                IPHostEntry _hostdns = null;
                IPAddress[] _hostip = null;
                IPAddress _ipv4 = null;

                try
                {
                    _hostname = System.Net.Dns.GetHostName();
                    _hostdns = System.Net.Dns.GetHostEntry(_hostname);
                    _hostip = _hostdns.AddressList;

                    for (int idx = _hostip.Length - 1; idx >= 0; idx--)
                    {
                        if (_hostip[idx].AddressFamily == AddressFamily.InterNetwork)
                        {
                            _ipv4 = _hostip[idx];
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    Debug.WriteLine(exc.Message);
                }

                return _ipv4;
            }
        }

        internal int Port(string port)
        {
            int getport;

            if(!int.TryParse(port, out getport))
            {
                getport = 8080;
            }

            return getport;
        }
    }
}
