using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public int MaxHP { get; private set; }
        public int CurrentHP { get; private set; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }
        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int Gold { get; private set; }

        public Inventory Inventory { get; }
        public Inventory EquipInventory { get; set; }

        public Player() 
        { 
            Inventory = new Inventory(6); // 인벤토리 최대 크기 6으로 설정
            EquipInventory = new Inventory(2); // 장비 인벤토리 최대 크기 2으로 설정 무기, 방어구
            MaxHP = 100;
            CurrentHP = MaxHP;
            AttackPower = 10;
            DefensePower = 5;
            Level = 1;
            Exp = 0;
            Gold = 0;
        }
        public void Heal(int amount)
        {
            CurrentHP += amount;
            if (CurrentHP > MaxHP)
            {
                CurrentHP = MaxHP;
            }
            Console.WriteLine($"체력이 {amount}만큼 회복되어 {CurrentHP}가 되었습니다.");
        }
        public void TakeDamage(int damage)
        {
            CurrentHP -= damage;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
        }
        public bool IsDead()
        {
            return CurrentHP <= 0;           
        }
        public void GainExp(int amount)
        {
            Exp += amount;
            if (Exp >= 100) // 레벨업 조건
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            Level++;
            Exp -= 100; // 레벨업 시 경험치 감소
            MaxHP += 10; // 레벨업 시 최대 HP 증가
            AttackPower += 2; // 레벨업 시 공격력 증가
            DefensePower += 1; // 레벨업 시 방어력 증가
            Console.WriteLine($"레벨업! 현재 레벨: {Level}");
        }
        public void AddGold(int amount)
        {
            Gold += amount;
            Console.WriteLine($"{amount}골드를 획득했습니다.");
        }
        public bool SpendGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
                Util.DeleteLine();
                Console.WriteLine($"{amount}골드를 사용했습니다.");
                return true;
            }
            else
            {
                Util.DeleteLine();
                Console.WriteLine("골드가 부족합니다.");
                return false;
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"레벨: {Level}, HP: {CurrentHP}/{MaxHP}, 공격력: {AttackPower}, 방어력: {DefensePower}, 경험치: {Exp}, 골드: {Gold}");
        }
        public void ShowInventory()
        {
            Inventory.ShowItems();
        }
       
    }
}
