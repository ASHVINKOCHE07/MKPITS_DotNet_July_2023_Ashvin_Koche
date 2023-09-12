#include<iostream>
using namespace std;
class CAbility {
	private:
		string cability;
	public:
		void cAbility(string ca) {
			cability=ca;
		}
		void Display() {
			cout<<"Character Ability= "<<cability<<endl;

		}
};
class Cequipment {
	private:
		string cequipment;
	public:
		void cEquipment(string ce) {
			cequipment=ce;
		}
		void Dispaly() {
			cout<<"Character Equipment= "<<cequipment<<endl;
		}
};
class Character : public CAbility,public Cequipment {
	private:
		string charactername;
	public:
		void Charactername(string cn,string ca,string ce) {
			charactername=cn;
			cAbility(ca);
			cEquipment(ce);

		}
		void Display() {
			CAbility::Display();
			Cequipment::Dispaly();
			cout<<"Character Name= "<<charactername<<endl;

		}
};
int main() {
	Character c1;
	c1.Charactername("ROCKY(K>G>F)","ATTACK","HAMMER");
	c1.Display();
	return 0;
}
