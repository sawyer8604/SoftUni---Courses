#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main() {

	string name;
	getline(cin, name);

	if (name == "square") {
		double length;
		cin >> length;
		cout << fixed << setprecision(3) << length * length << "\n";
	}
	else if (name == "rectangle") {
		double lengthA, lengthB;
		cin >> lengthA;
		cin >> lengthB;
		cout << fixed << setprecision(3) << lengthA * lengthB;
	}
	else if (name == "circle") {
		double r;
		cin >> r;
		cout << fixed << setprecision(3) << r * 3.14159265359 * r;
	}
	else if (name == "triangle") {
		double lengthA, lengthH;
		cin >> lengthA;
		cin >> lengthH;
		cout << fixed << setprecision(3) << lengthA * lengthH / 2 << "\n";
	}
	return 0;
}