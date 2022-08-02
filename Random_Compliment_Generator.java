```java
import java.util.Random;

public class ComplimentGenerator {
    public static void main(String[] args) {
        String[] compliments = {
                "You are an awesome friend.",
                "You are a gift to those around you.",
                "You are a smart cookie.",
                "You are amazing!",
                "You are a true friend.",
                "You are a ray of sunshine.",
                "You are a great listener.",
                "You are inspiring.",
                "You are a gem.",
                "You are a joy to be around."
        };

        Random random = new Random();
        int index = random.nextInt(compliments.length);

        System.out.println(compliments[index]);
    }
}
```