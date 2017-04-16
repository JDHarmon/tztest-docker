NET Core application to test container time zone settings.

The default time zone is America/New_York. To test a specific timezone, set the TZ environment variable:
```console
docker run --env TZ="UTC" jdharmon/tztest
```