#include <iostream>
#include <cmath>

using namespace std;

int main() {

	int brP, hoursP, hoursG;
	cin >> brP;
	hoursG = 365 - brP; // работни дни
	hoursP = 365 - hoursG; // почивни дни
	int realTime = (hoursG * 63) + (hoursP * 127);
	int razlika = abs(30000 - realTime) / 60; // За да неутрализираме знака в двете деления по-късно, ще използваме функцията abs(…)
	int minuti = abs(30000 - realTime) % 60;

	if (realTime > 30000) {
		cout << "Tom will run away" << "\n";
		cout << razlika << " hours and " << minuti << " minutes more for play " << "\n";
	}
	else {
		cout << "Tom sleeps well" << "\n";
		cout << razlika << " hours and " << minuti << " minutes less for play " << "\n";
	}



	return 0;
}