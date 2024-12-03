<p align="center">
  <img src="https://github.com/Holoon/Gladia/raw/main/doc/gladia_logo.jpg" width="256" title="Gladia Logo"> Gladia
</p>

# Holoon.Gladia

Unoffical SDK for Gladia.io

## Installation 

```
Install-Package Holoon.Gladia
```

Nuget package: https://www.nuget.org/packages/Holoon.Gladia/

## Usage

```c#
var logger = null; // TODO: Replace this by your instance of Microsoft.Extensions.Logging.ILogger
var file = new byte[0]; // TODO: Your audio file

var client = new GladiaClient(logger);
client.ApiKey = "xxx";

var upload = await client.UploadAsync(file, "audio/mp3", "audio/mpeg", cancellationToken);
if (upload?.AudioUrl == null)
    throw new InvalidOperationException("Audio file upload failed");

var request = new TranscribeRequest(upload.AudioUrl);
var transcribe = await _Client.TranscribeAsync(request, cancellationToken);
```

You can specify parameters to the Transcribe API. By example, for a diarization and a bullet points summarization:

```c#
var request = new TranscribeRequest(upload.AudioUrl,
	diarization: true, 
	summarization: true, 
	summarizationConfig: new SummarizationConfig("bullet_points")); 
```

**NOTES:**

- In this version, others (Live endpoints, webhooks, ...) are not implemented yet. 
Feel free to contribute! :)

## Quick Links

Gladia web site: https://www.gladia.io/
Official Gladia repository: https://github.com/gladiaio/
	
## Contributing

If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are welcome. Please respect existing style in code.

## Licensing

The code in this project is licensed under BSD-3-Clause license.
