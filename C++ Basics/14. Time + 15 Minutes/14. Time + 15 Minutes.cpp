#include <iostream>

using namespace std;

int main() {
	int hours = 0, minutes = 0;
	cin >> hours;
	cin >> minutes;

	if (minutes + 15 > 59) {
		hours++;
		minutes = minutes - 60;
	}
	if (hours > 23) {
		hours = hours - 24;
	}

	if (minutes + 15 < 10) {
		cout << hours << ":" << "0" << minutes + 15 << "\n";
	}
	else {
		cout << hours << ":" << minutes + 15 << "\n";
	}


	return 0;
}