using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    public class Motorway
    {
        public string _motorwayname;
        public string _direction;
        public string _surface;
        public int _noflanes;
        public bool _toll;
        public string _party;

        public Motorway()
        {

        }

        public string Fullname
        {
            get
            {
                return this._motorwayname;
            }
        }
        public int Numberoflanes
        {
            get
            {
                return this._noflanes;
            }
        }

        public bool Toll
        {
            get
            {
                return this._toll;
            }
        }

        public Motorway(string FullnameofMotorway)
        {
            this._motorwayname = FullnameofMotorway;
        }
        public Motorway(string FullnameofMotorway, bool Toll)
        {
            this._motorwayname = FullnameofMotorway;
            this._toll = Toll;
            Toll = true;
        }
        public Motorway(string FullnameofMotorway, int TotalLanes)
        {
            this._motorwayname = FullnameofMotorway;
            this._noflanes = TotalLanes;
        }

        public string party
        {
            get;
            set;
        }
        public string Direction
        {
            get;
            set;
        }

        public string Surface
        {
            get;
            set;
        }
        public bool IsToll
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Lane
        {
            get;
            set;
        }



        public override string ToString()
        {
            return this.Direction + "," + this.Name + "," + this.Lane + "," + this.party + "," + this.Surface + "," + this.IsToll;
        }
    }
}
