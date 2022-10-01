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