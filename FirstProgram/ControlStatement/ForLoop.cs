/**
Think of four loop as a block of code where an initialization statement occurs the first
time the loop is encountered. The termination condition is checked with each execution of the loop (
including after initialization), and the iteration condition is executed after each execution
of the loop.

for (Iterator<> itr = entity.itr(); itr.hasNext(); val = itr.next());

The initialization condition is always performed first (and once). The check condition is always
performed after the first execution of the loop (i.e, do we have a next). The reason
we prefer no to put the next in the for statement is that it will be executed once the loop has been executed
(although in this particular case, we can actually put it in the iteration condition).

*/