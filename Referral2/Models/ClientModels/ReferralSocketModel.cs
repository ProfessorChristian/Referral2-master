using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Referral2.Models.ClientModels
{
    public class ReferralSocketModel
    {
        public const string PORT = "8080";
        public const string INTERNET_PROTOCOL = "192.168.111.63";

        public static string SOCKET_LINK => $"ws://{INTERNET_PROTOCOL}:{PORT}";


        ///// <summary>
        ///// Padlock instance.
        ///// </summary>
        //public static object Padlock = new object();
        
        ///// <summary>
        ///// Create a global instance of this object.
        ///// </summary>
        //public static ReferralSocketModel instance = null;

        //public static ReferralSocketModel Instance
        //{
        //    get
        //    {
        //        lock(Padlock)
        //        {
        //            if(instance == null)
        //            {
        //                instance = new ReferralSocketModel();
        //            }
        //        }
        //        return instance;
        //    }
        //}


    }
}
