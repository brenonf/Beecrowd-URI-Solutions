x = input()
y = input()
z = input()

if x == 'vertebrado' and y == 'ave' and z == 'carnivoro':
    a = 'aguia'

if x == 'vertebrado' and y == 'ave' and z == 'onivoro':
    a = 'pomba'

if x == 'vertebrado' and y == 'mamifero' and z == 'onivoro':
    a = 'homem'

if x == 'vertebrado' and y == 'mamifero' and z == 'herbivoro':
    a = 'vaca'

if x == 'invertebrado' and y == 'inseto' and z == 'hematofago':
    a = 'pulga'

if x == 'invertebrado' and y == 'inseto' and z == 'herbivoro':
    a = 'lagarta'

if x == 'invertebrado' and y == 'anelideo' and z == 'hematofago':
    a = 'sanguessuga'

if x == 'invertebrado' and y == 'anelideo' and z == 'onivoro':
    a = 'minhoca'

print(a)
