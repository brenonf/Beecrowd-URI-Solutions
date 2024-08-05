n=list(map(float,input().split()))
if n[0]<n[1] and n[0]<n[2]:
    print("Otavio")
elif n[1]< n[0] and n[1]<n[2]:
    print("Bruno")
elif n[2]< n[0] and n[2]<n[1]:
    print("Ian")
else:
    print("Empate")