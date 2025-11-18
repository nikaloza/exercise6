function add(x: number, y: number): number          { return x + y; }
function subtract(x: number, y: number): number     { return x - y; }
function multiply(x: number, y: number): number     { return x * y; }
function divide(x: number, y: number): number       { return Math.trunc(x / y); }
function mod(x: number, y: number): number          { return x % y; }

function andFunc(x: boolean, y: boolean): boolean   { return x && y; }
function orFunc(x: boolean, y: boolean): boolean    { return x || y; }
function notFunc(x: boolean): boolean               { return !x; }

function greaterThan(x: number, y: number): boolean { return x > y; }
function lessEqual(x: number, y: number): boolean   { return x <= y; }
function equal(x: number, y: number): boolean       { return x === y; }


const a = 5, b = 3, c = 7, d = 4, e = 2, f = 10;
const x = true, y = false, z = true, isAdmin = false;

const expected1 = (a + b * c) > (d - e) && x || y;

const actual1 = orFunc(
    andFunc(
        greaterThan(
            add(a, multiply(b, c)),
            subtract(d, e)
        ),
        x
    ),
    y
);
console.log(`Expected1: ${expected1}, Actual1: ${actual1}`);

const expected2 = (a - b) * (c + d) <= e && z && !x;

const actual2 = andFunc(
    andFunc(
        lessEqual(
            multiply(
                subtract(a, b),
                add(c, d)
            ),
            e
        ),
        z
    ),
    notFunc(x)
);
console.log(`Expected2: ${expected2}, Actual2: ${actual2}`);

const expected3 = (a + b + c) % d == 0 || (f > e && isAdmin);

const actual3 = orFunc(
    equal(
        mod(
            add(add(a, b), c),
            d
        ),
        0
    ),
    andFunc(
        greaterThan(f, e),
        isAdmin
    )
);
console.log(`Expected3: ${expected3}, Actual3: ${actual3}`);


const expected4 = !(x || y) && (a * a > b * c);

const actual4 = andFunc(
    notFunc(
        orFunc(x, y)
    ),
    greaterThan(
        multiply(a, a),
        multiply(b, c)
    )
);
console.log(`Expected4: ${expected4}, Actual4: ${actual4}`);