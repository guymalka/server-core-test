using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public  class Appointments
    {
        private static Appointments instance = null;
        private static readonly object padlock = new object();

        public List< AppointmentTimeFrame > appointments = new List<AppointmentTimeFrame>();
        Appointments(){            
            for(int i = 8; i < 17 ; i++)
            {
                appointments.Add( new AppointmentTimeFrame(i) );
            }
        }

        public static Appointments Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Appointments();
                    }
                    return instance;
                }
            }
        }
        
    }

    public  class AppointmentTimeFrame
    {
        public AppointmentTimeFrame(int i)
        {
            start = i;

            //to create 59 mim - reduce 41
            end = i ;

        }        
        public int start { get; set; } 
        public int end { get; set; }
        

        public string startDisplay
        {
            get { 
                if (start < 10)
                    return string.Format("0{0}:00", start.ToString()); 
                else
                    return string.Format("{0}:00", start.ToString());
            }            
        }


        public string endDisplay
        {
            get
            {
                if (start < 10)
                    return string.Format("0{0}:59", end.ToString());
                else
                    return string.Format("{0}:59", end.ToString());
            }
        }


        public short count { get; set; } = 0;
        public List< string> names { get; set; }

    }
}
