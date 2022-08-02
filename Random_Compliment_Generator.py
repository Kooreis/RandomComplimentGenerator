```python
import random

def compliment_generator():
    adjectives = ["beautiful", "wonderful", "amazing", "inspiring", "impressive", "fantastic", "brilliant", "talented"]
    nouns = ["person", "soul", "heart", "mind", "individual", "being", "spirit", "character"]
    return "You are a " + random.choice(adjectives) + " " + random.choice(nouns) + "!"

if __name__ == "__main__":
    print(compliment_generator())
```