ComponentRenderIssue

This code demonstrates multiple rendering issues:

## Customization Dialog #1

1) A simple component in a dialog does not render its DatePicker & Select

2) DatePicker does not honor the Disabled flag

3) Select renders oddly. The first time the menu goes upwards and is narrow. The second invocation has the menu going downward. In neither case does the menu allow for all items to be shown even though there is plety of room.

## Customization Dialog #2

1) On the "type" tab choose the select; Instead of rendering in a rational fashion it gets compressed in the dialog & the dialog gets a scroll bar.

2) On the "filter" tab choose the select; You can't get to all of the 
 potential locations (1 - 20 are the targets)

3) This dialog has the wrappers, it they are too bothersome they can be removed but when executing under M.B 1.1.4 neither of these issues show up.
