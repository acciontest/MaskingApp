Feature: MaskingApp
	Mask the ssn numbers

Background:
  Given alteryx running at" http://gallery.alteryx.com/"
  And I am logged in using "deepak.manoharan@accionlabs.com" and "P@ssw0rd"

Scenario Outline: Mask the first 5 numbers of SSN number
	When I run the app <app> and I enter the SSN number "<text>"
	And I mask the first five digits of SSN with the specific character "<character>"
	Then I see the first five numbers are masked "<result>"
Examples: 
| app        | text                                         | character | result                                       |
| MaskingApp | My SSN is 123-45-6789 and I like it that way | X         | My SSN is XXX-XX-6789 and I like it that way |