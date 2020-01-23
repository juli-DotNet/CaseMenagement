

 class JtcmClass {
    constructor(private firstName: string) {

    }
    public visits: number = 0;
    private ourName: string;

    public showName(name: string): void {
        alert(this.firstName);
    }
    set name(val: string) {
        this.ourName = val;
    }
    get name() {
        return this.ourName;
    }
}
