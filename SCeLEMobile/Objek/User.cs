
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    [DataContract]
    public class User
    {
        [DataMember] 
        public string sitename { get; set; }
        [DataMember] 
        public string username { get; set; }
        [DataMember] 
        public string firstname { get; set; }
        [DataMember] 
        public string lastname { get; set; }
        [DataMember] 
        public string fullname { get; set; }
        [DataMember] 
        public string lang { get; set; }
        [DataMember] 
        public string userid { get; set; }
        [DataMember] 
        public string siteurl { get; set; }
        [DataMember] 
        public string userpictureurl { get; set; }
        [DataMember] 
        public string functions { get; set; }
        [DataMember] 
        public string token { get; set; }

        public User(RESPONSE r)
        {
            List<SINGLE> s = r.single;
            SINGLE s1 = s[0];
            List<KEY> keys = s1.key;

            foreach (KEY k in keys)
            {
                if (k.name.Equals("sitename"))
                {
                    sitename = k.VALUE;
                }
                else if(k.name.Equals("username")){
                    username = k.VALUE;
                }
                else if (k.name.Equals("firstname"))
                {
                    firstname = k.VALUE;
                }
                else if (k.name.Equals("lastname"))
                {
                    lastname = k.VALUE;
                }
                else if (k.name.Equals("fullname"))
                {
                    fullname = k.VALUE;
                }
                else if (k.name.Equals("lang"))
                {
                    lang = k.VALUE;
                }
                else if (k.name.Equals("userid"))
                {
                    userid = k.VALUE;
                }
                else if (k.name.Equals("siteurl"))
                {
                    siteurl = k.VALUE;
                }
                else if (k.name.Equals("userpictureurl"))
                {
                    userpictureurl = k.VALUE;
                }
                else if (k.name.Equals("functions"))
                {
                    functions = k.VALUE;
                }
            }
            
        }
    }
}
