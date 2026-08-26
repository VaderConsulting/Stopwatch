# Stopwatch

Stopwatch is a Pocket PC WinForms app with three independent row timers plus a main timer, each with Start, Stop, and Reset. A one-second `tmrMain` timer refreshes the running mm:ss labels (`0:00` at rest) via `TimeDifference`. Timer 1 can resume from the displayed elapsed time; timers 2, 3, and the main timer record `Now` only when their label is still `0:00`. Reset on timers 2, 3, and main stops the clock and clears the label; Reset on timer 1 only stops it.

**Source last updated:** 2004-08-12 · **Language:** VB.NET · **Target:** .NET Compact Framework 1.0 / Pocket PC · **Output:** Pocket PC WinForms WinExe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Stopwatch` | VB.NET | Pocket PC WinForms WinExe | Four concurrent stopwatches (three row timers plus a main timer) on `frmMain`; deploys to `\Program Files\Stopwatch` |

`frmMain (2).vb`, `frmMain (2).resx`, `AssemblyInfo (2).vb`, `Stopwatch (2).sln`, and `Stopwatch (2).vbdproj` are identical OneDrive copies of the primary files.

## How to open

Open `Stopwatch.sln` in Visual Studio .NET 2003 with Smart Device Extensions (Pocket PC). Later Visual Studio versions do not load `.vbdproj` device projects.

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `Stopwatch`. Assembly attributes (title, description, company, product, copyright) are empty Visual Studio template defaults. Solution format 8.00 / project ProductVersion 7.10.3077.

## License

MIT. Copyright (c) 2026 VaderConsulting, for Dave Robinson's code. See `LICENSE`.
