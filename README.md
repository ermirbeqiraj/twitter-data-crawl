# tweeter-data-crawl

This is a dotnet core console application that will be executed in a schedule.

I needed to gather some data in Albanian and the best suit for my project was to collect them from twitter, so this is what I came up with.

To get the app running you will need to complete appsettings.json file with the correct values.

The way app works is as follows:

- Read the latest status updates from some user (ideally a famous one, as the purpose of this app is to collect replies)
- Save them in a sql table, In this case I care about : Id, ReplyToId and message
- Then query the replies/tweets about main user tweets

