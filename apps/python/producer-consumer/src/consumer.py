"""Consumer module.

Provides a `Consumer` class that retrieves items from a shared
`queue.Queue`. Refactored for single-item consumption to align with
existing unit tests and improved for readability and maintainability.

Python 3.13+ compatible.
"""

from __future__ import annotations

from queue import Queue, Empty
import logging
from typing import Any, Optional

if not logging.getLogger(__name__).handlers:
    # Basic configuration; in larger apps prefer central configuration.
    logging.basicConfig(level=logging.INFO, format="%(asctime)s %(levelname)s %(name)s: %(message)s")
logger = logging.getLogger(__name__)


class Consumer:
    """Consume items from a shared queue.

    The `consume` method retrieves a single item from the queue and returns it.
    If the queue is empty, it returns `None` immediately. A `None` item can be
    used externally as a sentinel by producers to indicate termination; this
    class simply returns it unchanged.

    Parameters
    ----------
    shared_queue: Queue
        The queue instance shared with producers.
    """

    def __init__(self, shared_queue: Queue) -> None:
        self.shared_queue: Queue = shared_queue

    def consume(self, *, timeout: Optional[float] = None) -> Any:
        """Retrieve a single item from the queue.

        Parameters
        ----------
        timeout: Optional[float]
            Maximum seconds to wait for an item. If ``None`` (default), the
            call is non-blocking; if provided, the call blocks up to the given
            timeout. When timeout expires without an item, returns ``None``.

        Returns
        -------
        Any
            The next item from the queue, or ``None`` if the queue is empty
            (non-blocking) or the timeout expires.
        """
        if timeout is None:
            try:
                item = self.shared_queue.get_nowait()
            except Empty:
                logger.debug("Queue empty; returning None")
                return None
        else:
            try:
                item = self.shared_queue.get(timeout=timeout)
            except Empty:
                logger.debug("Timeout %.3fs expired waiting for item", timeout)
                return None

        logger.info("Consumed: %r", item)
        self.shared_queue.task_done()
        return item

