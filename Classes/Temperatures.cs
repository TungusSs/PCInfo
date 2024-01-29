namespace PCInfos
{
    //класс для полей
    class Temperatures
    {
        public string name;
        public float value;
        public float minvalue;
        public float maxvalue;

        public Temperatures(string name, float value, float minvalue, float maxvalue)
        {
            this.name = name;
            this.value = value;
            this.minvalue = minvalue;
            this.maxvalue = maxvalue;
        }
    }
}
