namespace DungeonLibrary
{
    //Abstract denotes an incomplete class or method. This tells the program that we will not create any character objects directly. 
    public  abstract class Character
    {
        //Fields

        /*
         * int life (cannot be more than maxlife
         * int maxlife (assign first in ctor)
         * string name 
         * int hitchance
         * int block
         * 
         */
        private int _block;
        private int _hitChance;
        private string _name;
        private int _maxLife;
        private int _life;


        //Properties - 1 for each field 
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }



        //Ctors - 1 fully qualified, 1 default/unqualified
        public Character(int block, int hitChance, string name, int maxLife)
        {
            Block = block;
            HitChance = hitChance;
            Name = name;
            MaxLife = maxLife;
            Life = maxLife;
        }
        public Character() { }



        //Methods
        //ToString() override

        //CalcBlock() returns an int -> return Block;
        //CalcHitChance() returns an int -> return HitChance;
        //CalcDamage() returns an int -> return 0;

        public override string ToString()
        {
            return $"\nName: {Name}\n" +
                   $"Block: {Block}\n" +
                   $"Hit Chance: {HitChance}\n" +
                   $"Max Life: {MaxLife}\n" +
                   $"Life: {Life}\n";
        }

        public virtual int CalculateBlock()
        {
            return Block;
        }
        public virtual int CalculateHitChance()
        {
            return HitChance;
        }
        public abstract int CalculateDamage(); //an abtract just says somewhere down the line, one of the child classes MUST implement this with some functionality. 
        
            
        
    }
}