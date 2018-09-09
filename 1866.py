def casos():
    c = int(input())
    return c

def paridade(n):
    if n % 2 == 0:
        print(0)
    else:
        print(1)

def inp():
    n = int(input())
    return n

def main():
    c = casos()
    for i in range(c):
       n = inp()
       paridade(n)

main()
    
