#include<iostream>
using namespace std;
class CAbility {
	public:
		string cability;
		void cAbility(string ca) {
			cability=ca;
		}
};
class Cequipment {
	public:
		string cequipment;
		void cEquipment(string ce) {
			cequipment=ce;
	}
};
class Character : public CAbility,public Cequipment {
	public:
		string charactername;
	public:
		void Charactername(string cn,string ca,string ce) {
			charactername=cn;
			cAbility(ca);
			cEquipment(ce);

		}
		void Display()
		{
	    cout<<"Character Name= "<<charactername<<endl;
		cout<<"Character Ability= "<<cability<<endl;
		cout<<"Character Equipment= "<<cequipment<<endl;
		}
};
int main() {
	Character c1;
	c1.Charactername("ROCKY(K>G>F)","ATTACK","HAMMER");
	c1.Display();
	return 0;
}
