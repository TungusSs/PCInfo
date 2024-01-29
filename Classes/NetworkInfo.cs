namespace OpenPCINFO
{
    // класс для полей
    class NetworkInfo
    {
        public string name;
        public string ip;
        public string mac;
        public long speed;
        public string ping;
        public string type;

        public NetworkInfo(string name, string ip)
        {
            this.name = name;
            this.ip = ip;
        }

        public NetworkInfo(string name, string ip, string mac)
        {
            this.name = name;
            this.ip = ip;
            this.mac = mac;
        }

        public NetworkInfo(string name, string ip, string mac, long speed, string ping, string type)
        {
            this.name = name;
            this.ip = ip;
            this.mac = mac;
            this.speed = speed;
            this.ping = ping;
            this.type = type;
        }

        public override string ToString()
        {
            return "name:" + this.name + " ip:" + this.ip + " mac:" + this.mac + " speed:" + this.speed + " ping:" + this.ping + " type:" + this.type;
        }


    }
}
