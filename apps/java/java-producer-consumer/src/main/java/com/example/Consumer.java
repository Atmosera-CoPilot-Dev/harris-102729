package com.example;

import java.util.concurrent.CompletableFuture;

/**
 * Consumer class that consumes messages produced by the Producer.
 */
public class Consumer {
  private final CompletableFuture<String> _task;

  /**
   * Constructor to initialize the Consumer with a CompletableFuture.
   *
   * @param task the CompletableFuture to be consumed
   */
  public Consumer(CompletableFuture<String> task) {
    _task = task;
  }

  /**
   * Asynchronously consumes the message from the producer and prints it to the console.
   */
  public void consumeAsync() {
    _task.thenAccept(message -> {
      System.out.println(message);
    });
  }
}