def add(x, y):          return x + y
def subtract(x, y):     return x - y
def multiply(x, y):     return x * y
def divide(x, y):       return x // y
def mod(x, y):          return x % y

def and_func(x, y):     return x and y
def or_func(x, y):      return x or y
def not_func(x):        return not x

def greater_than(x, y): return x > y
def less_equal(x, y):   return x <= y
def equal(x, y):        return x == y


a, b, c, d, e, f = 5, 3, 7, 4, 2, 10
x, y, z, is_admin = True, False, True, False


expected1 = (a + b * c) > (d - e) and x or y
actual1 = or_func(
    and_func(
        greater_than(
            add
        (a, multiply(b, c)),
            subtract
        (d, e)
        ),
        x
    ),
    y
)
print(f"Expected1: {expected1}, Actual1: {actual1}")


expected2 = (a - b) * (c + d) <= e and z and not x
actual2 = and_func(
    and_func(
        less_equal(
            multiply(
                subtract
            (a, b),
                add
            (c, d)
            ),
            e
        ),
        z
    ),
    not_func(x)
)
print(f"Expected2: {expected2}, Actual2: {actual2}")


expected3 = (a + b + c) % d == 0 or (f > e and is_admin)
actual3 = or_func(
    equal(
        mod(
            add
        (add
        (a, b), c),
            d
        ),
        0
    ),
    and_func(
        greater_than(f, e),
        is_admin
    )
)
print(f"Expected3: {expected3}, Actual3: {actual3}")


expected4 = not (x or y) and (a * a > b * c)
actual4 = and_func(
    not_func(
        or_func(x, y)
    ),
    greater_than(
        multiply(a, a),
        multiply(b, c)
    )
)
print(f"Expected4: {expected4}, Actual4: {actual4}")