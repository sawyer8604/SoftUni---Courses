#include <iostream>
#include <cmath>

using namespace std;

int main() {
	int V, P1, P2;
	double h;
	cin >> V >> P1 >> P2;
	cin >> h;
	int pipes = P1 + P2;
	double water = pipes * h;

	if (water <= V) {

		double sumPercent = trunc(water / V * 100);
		double Pipe1Percent = trunc(P1 * h / water * 100);
		double Pipe2Percent = trunc(P2 * h / water * 100);
		cout << "The pool is " << sumPercent << "% full. Pipe 1 :" << Pipe1Percent << "%. Pipe 2 :" << Pipe2Percent << "%." << "\n";
	}
	else {
		double difference = water - V;
		cout << "For " << h << " hours the pool overflows with " << difference << " litres" << "\n";
	}

	return 0;
}