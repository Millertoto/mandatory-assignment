using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Interfaces;
using mandatory_assignment.Weapons;

namespace mandatory_assignment
{
    public class Player
    {
        private readonly string _name;
        private readonly int _initialHitPoints;
        private int _hitPoints;
        private int _level;
        private readonly int _baseDefense;
        private int _defense;
        private readonly int _baseDamage;
        private int _damage;
        private int _experience;
        private IWeapon _currentWeapon;
        private readonly int _difficulty;

        public Player(string name, int initialHitPoints, int baseDefense, int baseDamage, int difficulty)
        {
            _name = name;
            _initialHitPoints = initialHitPoints;
            _level = 1;
            _baseDefense = baseDefense;
            _baseDamage = baseDamage;
            _experience = 0;
            _difficulty = difficulty;
            _currentWeapon = new Fists();
            CurrentValues();

        }

        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public bool Dead
        {
            get { return (_hitPoints <= 0); }
        }

        public void Reset()
        {
            _hitPoints = _initialHitPoints;
            _level = 1;
            _currentWeapon = new Fists();
            CurrentValues();
            Equipment();

        }

        public void LevelUp()
        {
            _level++;
            _experience = 0;
            CurrentValues();
            Equipment();
        }
        public void CurrentValues()
        {
            _hitPoints = _initialHitPoints + (_level * (_difficulty*2));
            _damage = _baseDamage + (_level * _difficulty);
            _defense = _baseDefense + _level * _difficulty;
        }

        public void Equipment()
        {
            _damage += _currentWeapon.damage;
        }

        public void status()
        {
            Console.WriteLine($"{Name} is level {Level}, has {_hitPoints} hit points, wields a {_currentWeapon.Name} that deals {_damage} each hit, has {_defense} defense and has {_experience} xp");
            if (Dead)
            {
                Reset();
            }
        }
        public int DealDamage()
        {

            Console.WriteLine($"{Name} Deals {_damage} points of damage");
            return _damage;
        }

        public void EquipWeapon(IWeapon Weapon)
        {
            if (_currentWeapon == null || _currentWeapon.damage <= Weapon.damage)
            {
                _currentWeapon = Weapon;
            }
            Equipment();
            Console.WriteLine(_currentWeapon.ToString());
        }

        public void ReceiveDamage(int damage)
        {
            _hitPoints = _hitPoints - (damage - _defense);
            Console.WriteLine($"{Name} has {_hitPoints} HP");
        }

        public void GainExperience(int xp)
        {
            _experience = _experience + xp;
            if (_experience >= (_level * 5))
            {
                LevelUp();
            }
        }
    }
}
