using System;

namespace RolePlayV10
{
    public class Warrior
    {
        private string _name;
        private int _level;
        private bool _Death;
        private int _DealDMG;
        private int _Start_Hitpoints;

        public Warrior(string name, int Start_Hitpoints)
        {
            _name = name;
            _level = 1;
            _Start_Hitpoints = Start_Hitpoints;
            
        }

        public string Name
        {
            get { return _name; }
        }
        
        public int level
        {
              get { return _level; }
        }

         public int Start_Hitpoints
        {
              get { return _Start_Hitpoints; }
        }

        public void levelUP()
        {
            _level = _level + 1;

        }
        public bool Death
        {
            get { return Start_Hitpoints <= 0; }
        }
    
        public int DealDMG()
        {
        Random RNG = new Random();
          _DealDMG = RNG.Next(10);
          return _DealDMG;
        }

    }
}