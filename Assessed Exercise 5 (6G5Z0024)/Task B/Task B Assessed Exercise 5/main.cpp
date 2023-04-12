//
//  main.cpp
//  Task B Assessed Exercise 5
//
//  Created by Seikou Bah Karagera on 08/01/2023.
//

#include <iostream>

bool FindSubstringCon(std::string S, std::string Y, std::string P, std::string Q){
  if (S.length() < Y.length() + P.length() + Q.length()) {
    return false;
  }

    int64_t position = S.find(Y);
    while (position != -1) {
      if (position >= P.length() && S.substr(position - P.length(), P.length()) == P &&
          S.substr(position + Y.length(), Q.length()) == Q) {
        return true;
      }
        position = S.find(Y, position + 1);
    }
  return false;
}

int main(int argc, const char* argv[]) {
    
    // Example for S: ABCDABCDACBD
    std::string S;
    std:: cout << "Please, enter the string to search in: " ;
    std:: cin >> S;
    
    // Example for Y: ABC
    std::string Y;
    std:: cout << "Please, enter the substring to search for: " ;
    std:: cin >> Y;

    // Example for P: ABCD
    std::string P;
    std:: cout << "Please, enter the substring that must come before Y: " ;
    std:: cin >> P;
    
    //Example for Q: DACBD

    std::string Q;
    std:: cout << "Please, enter the substring that must follow Y: " ;
    std:: cin >> Q;
    
    std:: cout << "There is an occurrence of Y with prefix P and suffix Q? " << std::boolalpha << FindSubstringCon(S, Y, P, Q) << std::endl;;
}

