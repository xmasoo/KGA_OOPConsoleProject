using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class Player
    {
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        private int currentHP;
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }


        private int attackPower;
        public int AttackPower { get { return attackPower; } set { attackPower = value; } }


        private int defensePower;
        public int DefensePower { get { return defensePower; } set { defensePower = value; } }


        private int level;
        public int Level { get { return level; } set { level = value; } }


        private int experience;
        public int Experience { get { return experience; } set { experience = value; } }


        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }


        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }


        public Player() 
        { 
            inventory = new Inventory(6); // 인벤토리 최대 크기 6으로 설정
            maxHP = 100;
            currentHP = maxHP;
            attackPower = 10;
            defensePower = 5;
            level = 1;
            experience = 0;
            gold = 0;
        }
        public void Heal(int amount)
        {
            currentHP += amount;
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
        }
        public void TakeDamage(int damage)
        {
            currentHP -= damage;
            if (currentHP < 0)
            {
                currentHP = 0;
            }
        }

        public void GainExperience(int amount)
        {
            experience += amount;
            if (experience >= 100) // 레벨업 조건
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            level++;
            experience -= 100; // 레벨업 시 경험치 감소
            maxHP += 10; // 레벨업 시 최대 HP 증가
            attackPower += 2; // 레벨업 시 공격력 증가
            defensePower += 1; // 레벨업 시 방어력 증가
            Console.WriteLine($"레벨업! 현재 레벨: {level}");
        }
        public void AddGold(int amount)
        {
            gold += amount;
            Console.WriteLine($"{amount}골드를 획득했습니다.");
        }
        public void SpendGold(int amount)
        {
            if (gold >= amount)
            {
                gold -= amount;
                Console.WriteLine($"{amount}골드를 사용했습니다.");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"레벨: {level}, HP: {currentHP}/{maxHP}, 공격력: {attackPower}, 방어력: {defensePower}, 경험치: {experience}, 골드: {gold}");
        }
        public void ShowInventory()
        {
            inventory.ShowItems();
        }
       
    }
}
