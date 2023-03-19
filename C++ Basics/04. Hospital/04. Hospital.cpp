#include <iostream>

using namespace std;

int main() {

	int period;
	int treatedPatiens = 0;
	int unTreatedPatiens = 0;
	int countOfDoctors = 7;

	cin >> period;

	for (int day = 1; day <= period; day++) {

		int curentPatients;
		cin >> curentPatients;

		if ((day % 3 == 0) && (unTreatedPatiens > treatedPatiens)) {
			countOfDoctors++;
		}
		if (curentPatients > countOfDoctors) {

			treatedPatiens += countOfDoctors;
			unTreatedPatiens += curentPatients - countOfDoctors;

		}
		else {
			treatedPatiens += curentPatients;
		}
	}

	cout << "Treated patients: " << treatedPatiens << "." << endl;
	cout << "Untreated patients: " << unTreatedPatiens << "." << endl;

	return 0;
}