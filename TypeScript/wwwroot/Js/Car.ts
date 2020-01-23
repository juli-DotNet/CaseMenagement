class Car {
    engine: string;

    constructor(engine: string) {
        this.engine = engine;
    }

    start() {
        alert("engine started:"+ this.engine);
    }

    stop() {
        alert("engine stoped:" + this.engine);
    }
}


window.onload = function() {
    var car = new Car("ac");

    car.start();
    car.stop();
}