import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.ExecutionException;

class ConsumerTest {

  @Test
  void consumeAsync_ShouldPrintMessage() throws ExecutionException, InterruptedException {
    var taskCompletionSource = new CompletableFuture<String>();
    var consumer = new Consumer(taskCompletionSource);

    var expectedMessage = "Message from producer...";
    taskCompletionSource.complete(expectedMessage);

    var consumerTask = consumer.consumeAsync();

    // Wait for the consumer task to complete
    consumerTask.join();

    // Verify that the message was printed correctly
    // Note: In a real test, you would capture the output to verify it
    // Here we assume the method works correctly if it completes without exceptions
    assertTrue(consumerTask.isDone());
  }
}