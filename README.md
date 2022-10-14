![PepperDash Essentials Plugin Logo](/images/essentials-plugin-blue.png)

# Planar QE Series Display Essentials Plugin (c) 2022

## Overview

This plugin is designed to work with Planar QE Series Displays controlled via RS-232 and  TCP/IP. For config information, see the [config snippets](##Configuration)

## Configuration

### RS-232

```json
{
  "key": "display-1",
  "uid": 4,
  "type": "planarqe",
  "name": "Display",
  "group": "display",
  "properties": {
    "control": {
      "controlPortDevKey": "processor",
      "controlPortNumber": 1,
      "method": "com",
      "comParams": {
        "protocol": "RS232",
        "baudRate": 19200,
        "hardwareHandshake": "None",
        "softwareHandshake": "None",
        "dataBits": 8,
        "parity": "None",
        "stopBits": 1
      }
    },
    "pollIntervalMs": 60000,
    "coolingTimeMs": 15000,
    "warmingTimeMs": 15000
  }
}
```

### TCP/IP

```json
{
  "key": "display-1",
  "uid": 4,
  "type": "planarqe",
  "name": "Display",
  "group": "display",
  "properties": {
    "control": {
      "method": "tcpIp",
      "tcpSshProperties": {
        "port": 57,
        "address": "0.0.0.0",
        "username": "",
        "password": "",
        "autoReconnect": true,
        "autoReconnectIntervalMs": 5000,
        "bufferSize": 32768
      }
    },
    "pollIntervalMs": 60000,
    "coolingTimeMs": 15000,
    "warmingTimeMs": 15000
  }
}
```

## Bridge JoinMap

### Digitals

| Join Number | JoinSpan | JoinName               | Description              | Type          | Capabilities |
| ----------- | -------- | ---------------------- | ------------------------ | ------------- | ------------ |
| 1           | 1        | PowerOff               | Power Off                | Digital       | FromSIMPL    |
| 2           | 1        | PowerOn                | Power On                 | Digital       | ToFromSIMPL  |
| 3           | 1        | IsTwoWayDisplay        | Is Two Way Display       | Digital       | ToSIMPL      |
| 5           | 1        | VolumeUp               | Volume Up                | Digital       | FromSIMPL    |
| 6           | 1        | VolumeDown             | Volume Down              | Digital       | FromSIMPL    |
| 7           | 1        | VolumeMute             | Volume Mute              | Digital       | ToFromSIMPL  |
| 8           | 1        | VolumeMuteOn           | Volume Mute On           | Digital       | ToFromSIMPL  |
| 9           | 1        | VolumeMuteOff          | Volume Mute Off          | Digital       | ToFromSIMPL  |
| 11          | 10       | InputSelectOffset      | Input Select             | Digital       | ToFromSIMPL  |
| 41          | 10       | ButtonVisibilityOffset | Button Visibility Offset | DigitalSerial | ToFromSIMPL  |
| 50          | 1        | IsOnline               | Is Online                | Digital       | ToSIMPL      |

### Analogs

| Join Number | JoinSpan | JoinName    | Description  | Type   | Capabilities |
| ----------- | -------- | ----------- | ------------ | ------ | ------------ |
| 5           | 1        | VolumeLevel | Volume Level | Analog | ToFromSIMPL  |
| 11          | 1        | InputSelect | Input Select | Analog | ToFromSIMPL  |

### Serials

| Join Number | JoinSpan | JoinName               | Description              | Type          | Capabilities |
| ----------- | -------- | ---------------------- | ------------------------ | ------------- | ------------ |
| 1           | 1        | Name                   | Name                     | Serial        | ToSIMPL      |
| 11          | 10       | InputNamesOffset       | Input Names Offset       | Serial        | ToSIMPL      |
| 41          | 10       | ButtonVisibilityOffset | Button Visibility Offset | DigitalSerial | ToFromSIMPL  |