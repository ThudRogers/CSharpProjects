using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Demonstrate duplicate detection with List<string> and HashSet<string>
        var items = new List<string> { "apple", "banana", "apple", "orange", "banana", "grape" };
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Duplicate check for items:");
        foreach (var item in items)
        {
            if (seen.Contains(item))
            {
                Console.WriteLine($"{item} (duplicate)");
            }
            else
            {
                Console.WriteLine($"{item} (first occurrence)");
                seen.Add(item);
            }
        }

        // Reusable responses (still here so your earlier loop work remains relevant)
        string[] responses =
        {
            "Thank you for contacting support.",
            "We appreciate your patience.",
            "Your case is being reviewed:",
            "Here is the information you provided:"
        };

        // Knowledge base: issue -> (diagnostic, steps)
        var kb = new Dictionary<string, (string Diagnostic, List<string> Steps)>(StringComparer.OrdinalIgnoreCase)
        {
            ["Login Problem"] = (
                "We detected a possible session or credential issue.",
                new List<string>
                {
                    "Check that Caps Lock is off and username is correct.",
                    "Reset your password if you cannot log in after two attempts.",
                    "Clear browser cache and cookies, then try again.",
                    "If using SSO, confirm you are logged into the correct account.",
                    "Try a different browser or device."
                }
            ),
            ["Password Reset"] = (
                "Password reset email may be blocked or delayed.",
                new List<string>
                {
                    "Check spam or junk folders for the reset email.",
                    "Wait two minutes and request another reset link.",
                    "Whitelist no-reply@company.example.",
                    "Ensure your mailbox is not full.",
                    "If link expired, request a fresh link and use immediately."
                }
            ),
            ["Billing Error"] = (
                "There may be a mismatch between invoice and account status.",
                new List<string>
                {
                    "Verify the last four digits of the card on file.",
                    "Confirm billing address matches your card statement.",
                    "Check for duplicate charges on the same date.",
                    "Download the latest invoice from your account page.",
                    "Contact your bank to rule out a declined or pending charge."
                }
            ),
            ["Technical Glitch"] = (
                "A temporary service or client-side error might be occurring.",
                new List<string>
                {
                    "Refresh the page and try the action again.",
                    "Log out and back in to refresh your session.",
                    "Disable browser extensions and retry.",
                    "Try in a private/incognito window.",
                    "Check status.company.example for any ongoing incidents."
                }
            )
        };

        while (true) // Infinite loop for repeated use
        {
            Console.WriteLine("\nWelcome to Support Assistant.");
            Console.Write("Please enter your name (or type 'exit' to quit): ");
            string name = Console.ReadLine();
            if (name != null && name.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Session ended. Have a great day!");
                break;
            }

            // Show available issues
            Console.WriteLine("\nAvailable issue types:");
            int idx = 1;
            foreach (var issueName in kb.Keys)
            {
                Console.WriteLine($"{idx}. {issueName}");
                idx++;
            }

            Console.Write("\nType the issue exactly as shown above (or type 'exit' to quit): ");
            string selectedIssue = Console.ReadLine();
            if (selectedIssue != null && selectedIssue.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Session ended. Have a great day!");
                break;
            }

            // Practical use of your existing responses array with loops
            Console.WriteLine("\nSystem response:");
            for (int i = 0; i < responses.Length; i++) // '<' loop
            {
                if (i == 2)
                    Console.WriteLine(responses[i] + " " + selectedIssue);
                else if (i == 3)
                    Console.WriteLine(responses[i] + " " + name);
                else
                    Console.WriteLine(responses[i]);
            }

            Console.WriteLine("\nConfirming details with an alternate loop style:");
            for (int i = 0; i <= responses.Length - 1; i++) // '<=' loop
            {
                Console.WriteLine($"[{i}] {responses[i]}");
            }

            // Lookup and print diagnostic + steps
            if (kb.TryGetValue(selectedIssue ?? string.Empty, out var info))
            {
                Console.WriteLine($"\nHi {name}, here is your diagnostic for \"{selectedIssue}\":");
                Console.WriteLine("- " + info.Diagnostic);

                Console.WriteLine("\nRecommended steps:");
                int stepNum = 1;
                foreach (var step in info.Steps)
                {
                    Console.WriteLine($"{stepNum}. {step}");
                    stepNum++;
                }
            }
            else
            {
                Console.WriteLine("\nWe could not find that issue type. Please select one from the list provided.");
            }

            Console.WriteLine("\nPress Enter to start a new session or type 'exit' and press Enter to quit.");
            string again = Console.ReadLine();
            if (again != null && again.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Session ended. Have a great day!");
                break;
            }
        }
    }
}
