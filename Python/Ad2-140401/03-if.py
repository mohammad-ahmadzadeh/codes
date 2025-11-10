s=input("Enter a: ")
a=int(s)
s=input("Enter b: ")
b=int(s)

if a>b:
    print(a)
    a=a+2
    print(a)
elif b>a:
    print(b)
else:
    print("a=b")
