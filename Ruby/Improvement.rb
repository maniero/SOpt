if contract.amendments.empty?
  due_date = contract.due_date
  end_date = contract.end_date
  condition = Date.today - contract.due_date < 30
else
  due_date = contract.amendments.last.due_date
  end_date = contract.amendments.last.end_date
  condition = Date.today - last_amendment.end_date < 30
end
if Date.today - due_date >= 30 || Date.today + due_date <= 30
  @start_date = end_date + 1
  @end_date = end_date + 365
elsif condition
  @start_date = Date.today
  @end_date = end_date
end

#https://pt.stackoverflow.com/q/58541/101
