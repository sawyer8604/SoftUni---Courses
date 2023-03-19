#include <iostream>

using namespace std;

int main() {
    int h, x, y;
    cin >> h >> x >> y;

    if ((x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h))
    {
        if ((x > 0) && (x < 3 * h) && (y > 0) && (y < h)) {
            cout << "inside" << endl;
        }
        else if ((x > h) && (x < 2 * h) && (y == h)) {
            cout << "inside" << endl;
        }
        else {
            cout << "border" << endl;
        }
    }
    else if ((x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h))
    {
        if ((x > h) && (x < 2 * h) && (y > h) && (y < 4 * h)) {
            cout << "inside" << endl;
        }
        else if ((x > h) && (x < 2 * h) && (y == h)) {
            cout << "inside" << endl;
        }
        else {
            cout << "border" << endl;
        }
    }
    else {

        cout << "outside" << endl;
    }



    return 0;
}