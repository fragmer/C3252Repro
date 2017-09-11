// App.cpp : main project file.

#include "stdafx.h"

using namespace ManagedLib;

int main(array<System::String ^> ^args)
{
	Case1::Foo^ foo1 = gcnew Case1::Foo();
	Case2::Foo^ foo2 = gcnew Case2::Foo();
    return 0;
}
