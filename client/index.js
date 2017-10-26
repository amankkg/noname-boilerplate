// @flow

class Animal {}

class Dog extends Animal {
  woof() {
    console.log('woof');
  }
}

class Cat extends Animal {
  meow() {
    console.log('meow');
  }
}

const dogs : Dog[] = [new Dog()];
const animals : Animal[] = dogs;
animals.push(new Cat());
