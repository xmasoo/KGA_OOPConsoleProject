using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }
        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int Gold { get; set; }

        public Player() 
        { 
            MaxHP = 100;
            CurrentHP = MaxHP;
            AttackPower = 10;
            DefensePower = 5;
            Level = 1;
            Exp = 0;
            Gold = 50;
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
            while (Exp > 100)
            {
                if (Exp >= 100) // 레벨업 조건
                {
                    LevelUp();
                }
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

        public void EffectOn(Item item)//아이템 장착 혹은 사용했을 때 스테이터스 변동
        {
            string s;
            s = item.Equipable ? "장착" : "사용";
            Console.WriteLine($"{item.Name}을 {s}하여 플레이어의 {item.Effect}이(가) {item.EffectValue}만큼 상승했습니다!");
            switch(item.Effect)
            {
                case "공격력":
                    AttackPower += item.EffectValue;
                    break;
                case "방어력":
                    DefensePower += item.EffectValue;
                    break;
                case "체력":
                    MaxHP += item.EffectValue;
                    break;
            }
            Util.PressAnyKey();
        }

        public void EffectOff(Item item)// 아이템을 해제했을 때 
        {
            Console.WriteLine($"{item.Name}을 탈착해서 플레이어의 {item.Effect}이(가) {item.EffectValue}만큼 하락했습니다!");
            switch (item.Effect)
            {
                case "공격력":
                    AttackPower -= item.EffectValue;
                    break;
                case "방어력":
                    DefensePower -= item.EffectValue;
                    break;
            }
            Util.PressAnyKey();
        }
        public void ShowStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"레벨: {Level}, HP: {CurrentHP}/{MaxHP}, 공격력: {AttackPower}, 방어력: {DefensePower}, 경험치: {Exp}, 골드: {Gold}");
        }
        public void ShowInventory()
        {
            Console.WriteLine();
            Game.equipInventory.ShowItems();
            Game.inventory.ShowItems();
        }
        public void ShowInventory(int a)//임시 장비만 보여주기용으로
        {
            Console.WriteLine();
            Game.equipInventory.ShowItems();
        }
    }
}
