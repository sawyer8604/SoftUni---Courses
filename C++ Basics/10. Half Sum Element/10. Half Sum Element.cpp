#include <iostream>
#include <cmath>

using namespace std;

int main() {

	int n, max = 0;
	cin >> n;

	int sum = 0;

	for (int i = 0; i < n; i++) {
		int num;
		cin >> num;
		sum += num;

		if (num > max) {
			max = num;

		}

	}
	sum = sum - max;
	if (sum == max) {
		sum = sum - max;
		cout << "Yes Sum = " << max << endl;
	}
	else {

		int diff = abs(sum - max);
		cout << "No Diff = " << diff << endl;
	}


	return 0;
}