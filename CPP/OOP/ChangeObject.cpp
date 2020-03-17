class C {
	private:
		int d;
	public:
		void add(int x);
};

void C::add(int x) {
	d = x + 10;
	return;
}

class B {
	private:
		C c;		
	public:
		C copy();
};

C B::copy() {
	c.add(1);	
	return c;
}

class A {
	private:
		void start();
		B b;
		C c;		
};

void A::start() {
	c = b.copy();
}

int main() {}

//https://pt.stackoverflow.com/q/160671/101
