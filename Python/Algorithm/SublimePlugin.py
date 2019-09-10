import sublime, sublime_plugin
import sort

def line_length_sort(txt):
    txt.sort(lambda a, b: cmp(len(a), len(b)))
    return txt

class SortLinesLengthCommand(sublime_plugin.TextCommand):
    def run(self, edit, reverse=False,
                        remove_duplicates=False):
        view = self.view

        sort.permute_lines(line_length_sort, view, edit)

        if reverse:
            sort.permute_lines(sort.reverse_list, view, edit)

        if remove_duplicates:
            sort.permute_lines(sort.uniquealise_list, view, edit)

#https://pt.stackoverflow.com/q/74636/101
